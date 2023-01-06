#include <arpa/inet.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <sys/socket.h>
#include <unistd.h>
#define PORT 1999
 
int main(int argc, char const* argv[])
{
    int sock = 0, valread, client_fd;
    struct sockaddr_in serv_addr;
    char* hello = "Hello from client";
    char buffer[1024] = { 0 };
    if ((sock = socket(AF_INET, SOCK_STREAM, 0)) < 0) {
        printf("\n Socket creation error \n");
        return -1;
    }
 
    serv_addr.sin_family = AF_INET;
    serv_addr.sin_port = htons(PORT);
 
    // Convert IPv4 and IPv6 addresses from text to binary
    // form
    if (inet_pton(AF_INET, "127.0.0.1", &serv_addr.sin_addr)
        <= 0) {
        printf(
            "\nInvalid address/ Address not supported \n");
        return -1;
    }
 
    if ((client_fd
         = connect(sock, (struct sockaddr*)&serv_addr,
                   sizeof(serv_addr)))
        < 0) {
        printf("\nConnection Failed \n");
        return -1;
    }

    char ClientName[105];
    char RoomId[105];
    int InRoom=0;
    scanf("%s" , ClientName );
    scanf("%s" , RoomId );

    int LIVE = 1;
    int RoomInit = 0;

    char respond[1024] = {};
    char token[105] = { };
    while( LIVE ){
        
        strncpy(token,buffer,4);

        if( !InRoom && strcmp(token,"join") == 0 ){
            printf("Join Room %s !!!\n" , RoomId );
            InRoom = !InRoom;
        }
        
        if( InRoom ){
            // recieve == buffer
            char input[105];
            printf("input message to chat : ");
            scanf("%s" , input );
            // chat:{who:{name},con:{word}}
            strcat( respond , "chat:{who:{");
            strcat( respond , ClientName );
            strcat( respond , "},con:{");
            strcat( respond , input );
            strcat( respond , "}");

            send(sock, respond, strlen(respond), 0);
        }
        
        if( !InRoom ){
            // try join room 
            strcat(respond,"join:");
            strcat(respond,RoomId);
            strcat(respond,":");
            strcat(respond,ClientName);

            printf("send msg to join room\n");
            send(sock, respond, strlen(respond), 0);
        }
        
        if( strlen(buffer) >0 ) printf("Log : %s\n" , buffer );
        if( strlen(buffer) >0 ) memset(buffer,0,sizeof(buffer));
        if( strlen(respond) >0 ) memset(respond,0,sizeof(respond));
        if( strlen(token) >0 ) memset(token,0,sizeof(token));

        LIVE = read(sock, buffer, 1024);
    }


    // closing the connected socket
    close(client_fd);
    return 0;
}