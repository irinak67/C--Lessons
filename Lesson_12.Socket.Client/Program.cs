﻿// See https://aka.ms/new-console-template for more information

//Client
using System.Net;
using System.Net.Sockets;
using System.Text;

const string ip = "127.0.0.1";
const int port = 8080;

var tcpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);

var tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

Console.WriteLine("Insert your message: ");
var message = Console.ReadLine();

var data = Encoding.UTF8.GetBytes(message);

tcpSocket.Connect(tcpEndPoint);
tcpSocket.Send(data);

var buffer = new byte[256];
var size = 0;
var answer = new StringBuilder();

do
{
    size = tcpSocket.Receive(buffer);
    answer.Append(Encoding.UTF8.GetString(buffer, 0, size));
}
while (tcpSocket.Available > 0);

Console.WriteLine(answer.ToString());

tcpSocket.Shutdown(SocketShutdown.Both);
tcpSocket.Close();

Console.ReadLine();