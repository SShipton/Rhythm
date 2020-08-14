using System;
using System.Linq;
using Band;
using Microsoft.EntityFrameworkCore;

namespace Rhythm
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new BandContext();

            var bands = context.Bands.Include(bands => band.Album);

            var bandCount = bands.Count();

            Console.WriteLine($"There are {bandCount} bands");

            foreach (var album in bands)
            {
                if (band.Album == null)
                {
                    Console.WriteLine($"There is a band named {band.Name} - no albums yet!")
                }
                else
                {
                    Console.WriteLine($"There is a band named {band.Name} - {band.Album.Title}");
                }
            }
        }
    }
}
