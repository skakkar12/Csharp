using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResearchCSharp.ObjectOrientedDesign
{
    class AlbumTest
    {
        public static void Main(String[] args)
        {
            bool debug=false;

            PhotoAlbum myalbum = new PhotoAlbum();
            Console.WriteLine(myalbum.GetNoOfPages());

            PhotoAlbum myalbum2 = new PhotoAlbum();
            Console.WriteLine(myalbum2.GetNoOfPages());

            BigPhotoAlbum mybigalbum = new BigPhotoAlbum();
            Console.WriteLine(mybigalbum.GetNoOfPages());

            if (debug)
            {
                Console.ReadLine();
            }
        }
    }


    class PhotoAlbum
    {
        public int NoOfPages { get; set; }

        public int GetNoOfPages()
        {
            return NoOfPages;
        }
    }

    class BigPhotoAlbum:PhotoAlbum
    {
        public BigPhotoAlbum()
        {
            NoOfPages = 64;
        }
    }
}
