﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    public class Post
    {
        public long ID { get; set; }
        public string url { get; set; }
        public double geoposition { get; set; }
        public double azimut { get; set; }
        public DateTime  date { get; set; }
        public int idCreator  { get; set; }

public Post()
        {
            url = "";
            geoposition = 0;
            azimut = 0;
            idCreator = 0;
            date = DateTime.Now;
        }
    }
}
