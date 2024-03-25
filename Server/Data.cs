﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

    namespace DevelopersHub.RealtimeNetworking.Server
    {
        public static class Data
        {
            public class Player
            {
                public int food = 0;
                public int wood = 0;
                public int stone = 0;
                public int gold = 0;
                public int gem = 0;
            }

            public static string Serialize<T>(this T target)
            {
                XmlSerializer xml = new XmlSerializer(typeof(T));
                StringWriter writer = new StringWriter();
                xml.Serialize(writer, target);
                return writer.ToString();
            }

            public static T Deserialize<T>(this string target)
            {
                XmlSerializer xml = new XmlSerializer(typeof(T));
                StringReader reader = new StringReader(target);
                return (T)xml.Deserialize(reader);
            }
        }
    }
