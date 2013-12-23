﻿using System;
using MongoDB.Attributes;
namespace Lottery.Entity
{
    public class VideoInfo
    {
        [MongoId]
        public string ID { set; get; }

        public string Name { set; get; }

        public string Image { set; get; }

        public string File { set; get; }

        public DateTime? Date { set; get; }

        public int? Status { set; get; }
    }
}
