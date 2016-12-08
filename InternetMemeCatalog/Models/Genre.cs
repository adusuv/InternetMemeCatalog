using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternetMemeCatalog.Models
{

    public class Genre
    {
        public string GenreName;
        public IEnumerable<Image> Images;
    }
}