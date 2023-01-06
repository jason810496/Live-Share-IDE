#include <netinet/in.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <sys/socket.h>
#include <unistd.h>
#define PORT 1999
int main(int argc, char const* argv[])
{
    int server_fd, new_socket, valread;
    struct sockaddr_in address;
    int opt = 1;
    int addrlen = sizeof(address);
    char buffer[1024] = { 0 };
    char* hello = "Hello from server";
 
    // Creating socket file descriptor
    if ((server_fd = socket(AF_INET, SOCK_STREAM, 0)) < 0) {
        perror("socket failed");
        exit(EXIT_FAILURE);
    }
 
    // Forcefully attaching socket to the port 8080
    // if (setsockopt(server_fd, SOL_SOCKET,SO_REUSEADDR | SO_REUSEPORT, &opt,sizeof(opt))) {
    if( setsockopt(server_fd, SOL_SOCKET, SO_REUSEADDR , &opt, sizeof(opt)) ) {
        perror("setsockopt");
        exit(EXIT_FAILURE);
    }
    address.sin_family = AF_INET;
    address.sin_addr.s_addr = INADDR_ANY;
    address.sin_port = htons(PORT);
 
    // Forcefully attaching socket to the port 8080
    if (bind(server_fd, (struct sockaddr*)&address,
             sizeof(address))
        < 0) {
        perror("bind failed");
        exit(EXIT_FAILURE);
    }
    if (listen(server_fd, 3) < 0) {
        perror("listen");
        exit(EXIT_FAILURE);
    }
    if ((new_socket
         = accept(server_fd, (struct sockaddr*)&address,
                  (socklen_t*)&addrlen))
        < 0) {
        perror("accept");
        exit(EXIT_FAILURE);
    }


    
    int total_client = 0 ;
    int total_room =  0;

    int LIVE = read(new_socket, buffer, 1024); 

    while( LIVE ){
        char token[105] = {};
        char respond[105] = {};
        strncpy(token,buffer,4);
        
        if( strcmp(token,"join") == 0 ){
            total_client ++;
            printf("New Client Join !\n");
            printf("Client size : %d\n" , total_client );

            strcpy(respond,"join");
            send(new_socket, respond, strlen(respond), 0);
        }
        if( strcmp(token,"chat") == 0 ){
            printf("recv : %s\n" , buffer );

            strcpy(respond,"recv");
            send(new_socket , respond ,strlen(respond) , 0);
        }

        if( strlen(buffer) >0 ) memset(buffer,0,sizeof(buffer));
        if( strlen(respond) >0 ) memset(respond,0,sizeof(respond));
        if( strlen(token) >0 ) memset(token,0,sizeof(token));

        printf("status : \n");
        printf("Client size : %d\n" , total_client );
        LIVE = read(new_socket, buffer, 1024);
    }
    // printf("Hello message sent\n");
 



    // closing the connected socket
    close(new_socket);
    // closing the listening socket
    shutdown(server_fd, SHUT_RDWR);
    return 0;
}