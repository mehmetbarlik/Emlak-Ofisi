using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class FavoriteList
    {
        public List<FavoriteListLine> Lines { get; set; }
        public FavoriteList()
        {
            Lines = new List<FavoriteListLine>();
        }

        public virtual void AddItem(Estate estate, int quantity)
        {
            FavoriteListLine? line = Lines.Where(l => l.Estate.EstateId.Equals(estate.EstateId)).FirstOrDefault();
            if (line is null)
            {
                Lines.Add(new FavoriteListLine()
                {
                    Estate = estate,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity = quantity;
            }
        }

        public virtual void RemoveLine(Estate estate) => Lines.RemoveAll(l => l.Estate.EstateId.Equals(estate.EstateId));

        public virtual void Clear() => Lines.Clear();

    }
}
