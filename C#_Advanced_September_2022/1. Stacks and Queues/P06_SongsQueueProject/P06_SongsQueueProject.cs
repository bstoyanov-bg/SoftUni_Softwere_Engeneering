using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace P06_SongsQueueProject
{
    internal class P06_SongsQueueProject
    {
        static void Main(string[] args)
        {
            string[] inputSongs = Console.ReadLine()
                .Split(", ")
                .ToArray();

            var songsQueue = new Queue<string>(inputSongs);

            while (songsQueue.Count > 0)
            {
                string[] command = Console.ReadLine()
                    .Split()
                    .ToArray();

                string action = command[0];

                if (action == "Play")
                {
                    songsQueue.Dequeue();
                }
                else if (action == "Add")
                {
                    var songToAdd = String.Join(" ", command.Skip(1));
                    if (songsQueue.Contains(songToAdd))
                    {
                        Console.WriteLine($"{songToAdd} is already contained!");
                    }
                    else
                    {
                    songsQueue.Enqueue(songToAdd);
                    }
                }
                else if (action == "Show")
                {
                    Console.WriteLine(String.Join(", ", songsQueue));
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}