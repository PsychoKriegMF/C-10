using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_10
{
    public interface IBook
    {
        string Title {  get; }
        string Author { get; }
        string Genre { get; }
        double Price { get; }
        int PublicationYear { get; }
    }
}
