﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StackAlgorithm
{
    internal class Program
    {
        class Node
        {
            /*creates Node for the cicular nexted list*/
            public int rollNumber;
            public string nama;
            public Node next;
        }

        class CircularList
        {
            Node LAST;
            public CircularList()
            {
                LAST = null;
            }
            static void Main(string[] args)
            {
            }
            //add node
            public void addnode()
            {
                int number;
                string nm;

                //deklarasi element
                Console.WriteLine("\nMasukkan No.Mahasiswa : ");
                number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nMasukkan No.Mahasiswa : ");
                nm = Console.ReadLine();

                Node newnode = new Node();

                //membuat penyimpanan
                newnode rollNumnber;
                newnode.nama = nm;

                //if list empty
                if (listempty())
                {
                    newnode.next = newnode;
                    LAST = newnode;
                 //mulai proses pengurutan proses pengurutan data
                else if (number < LAST.next.rollNumber)//node dari kiri
                    {
                        newnode.next = LAST.next;
                        LAST.next = newnode;
                    }
                    else if (number > LAST.rollNumber)//node dari kanan
                    {
                        newnode.next = LAST.next;
                        LAST.next = newnode;
                        LAST = newnode;
                    }
                    //menambahkan node ditengah-tengah
                    else
                    {
                        Node current, previous;
                        current = previous = LAST.next;

                        int i = 0;
                        while (i < number - 1)
                        {
                            previous = current;
                            current = current.next;
                            i++;
                        }
                        newnode.next = current;
                        previous.next = newnode;

                    }
                }
            
            }
        }
    }
}



 
