import socket, select ,json

'''
{"event":"join","room":room_id,"user":"name"}
{"event":"leav","room":room_id,"user":"name"}
{"event":"mesg","room":room_id,"user":"name","content":"abcd..."}
{"event":"code","room":room_id,"user":"name","content":"abcd..."}
{"event":"open","room":room_id,"user":"name","content":"abcd..."}
'''

#Function to send message to all connected clients
def send_to_all (sock,room,message):
	#Message not forwarded to server and sender itself
	for socket in room.values():
		if socket != server_socket and socket != sock :
			try :
				socket.send(message)
			except :
				# if connection not available
				socket.close()
				connected_list.remove(socket)

if __name__ == "__main__":
	name=""
	# dict store -> sock: [user,room]
	record={}
	# dict to store address by room id 
	room={}
	# List to keep track of socket descriptors
	connected_list = []
	buffer = 4096
	port = 52023

	server_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
	# The second argument determines the socket type; socket.SOCK_DGRAM is UDP, socket.SOCK_STREAM is a TCP socket. This all provided you are using a AF_INET or AF_INET6 socket family.


	server_socket.bind(("127.0.0.1", port))
	server_socket.listen(55) #listen atmost 55 connection at one time

	# Add server socket to the list of readable connections
	connected_list.append(server_socket)

	print( "\33[32m \t\t\t\tSERVER WORKING \33[0m" )

	while 1:
		# Get the list sockets which are ready to be read through select
		rList,wList,error_sockets = select.select(connected_list,[],[])

		for sock in rList:
			#New connection
			if sock == server_socket:
				# Handle the case in which there is a new connection recieved through server_socket
				sockfd, addr = server_socket.accept()
				print("new connection : ",sockfd,addr)
				b_raw=sockfd.recv(buffer)
				print("Recv :",b_raw.decode())
				connected_list.append(sockfd)
				#print "record and conn list ",record,connected_list
				token = json.loads(b_raw.decode())
				record[addr]=[token['user'],token['room']]
				print("token" , token )
				
				if token['room'] not in room:
					room[ token['room'] ] = {}
				
				if token['user'] in room[ token['room'] ]:
					sockfd.send(str.encode("Username already taken!"))
					del room[ token['room'] ][ token['user'] ]
					connected_list.remove(sockfd)
					sockfd.close()
					continue
				else:
					#add name and address
					room[ token['room'] ][ token['user'] ] = sockfd; 
					print( "Client (%s, %s) connected" % addr," [",room[ token['room'] ][ token['user'] ],"]" )
					sockfd.send( str.encode("\33[32m\r\33[1m Welcome to chat room. Enter 'tata' anytime to exit") )
					print("room:",room[ token['room'] ])
					send_to_all(sockfd,room[ token['room'] ], str.encode(token['user'] +" joined the conversation") )
			#Some incoming message from a client
			else:
				# Data from client
				try:
					b_raw = sock.recv(buffer)
					print("recv : " ,b_raw )
					token = json.loads(b_raw.decode())
					print("token" , token )
					# data=data1[:data1.index("\n")]
					#print "\ndata received: ",data
					# print("data : " , data )

					#get addr of client sending the message
					i,p=sock.getpeername()
					if   token['event'] == 'leav':
						msg=record[(i,p)]+" left the conversation"
						send_to_all(sock,room[ token['room'] ],msg)
						print( "Client (%s, %s) is offline" % (i,p)," [",record[(i,p)],"]" )
						del room[ token['room'] ][ token['user'] ]
						connected_list.remove(sockfd)
						sockfd.close()
						continue
					elif token['event'] == 'mesg':
						msg=token['content']
						send_to_all(sock, room[ token['room'] ],str.encode(msg) )
					elif token['event'] == 'code':
						msg=token['content']
						send_to_all(sock, room[ token['room'] ],str.encode("^=][=^"+msg) )
			
				#abrupt user exit
				except:
					(i,p)=sock.getpeername()
					send_to_all(sock,room[ record[(i,p)][1] ] ,str.encode(record[(i,p)][0]+" left the conversation unexpectedly\33[0m\n") )
					print( "Client (%s, %s) is offline (error)" % (i,p)," [",record[(i,p)][0],"]\n" )
					del room[ token['room'] ][ record[(i,p)][0] ]
					connected_list.remove(sock)
					sock.close()
					if len(room[ token['room'] ]) is 0:
						del room[ token['room'] ]
					continue

	server_socket.close()