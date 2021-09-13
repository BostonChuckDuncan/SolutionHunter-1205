using System;
using System.ComponentModel.DataAnnotations;

namespace API.Entity
{
    public class RandomCache 
    {
        public int Id { get; set; }
        public byte[] BinaryStream { get; set; }
    }
}
