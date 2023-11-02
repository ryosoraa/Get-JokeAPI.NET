using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_JokeAPi.NET.src.model.DTO
{
    public class JokesDTO
    {
        private string status
        {
            get; set;
        }

        private string total
        {
            get; set;
        }

        private string end_point
        {
            get; set;
        }

        private string method
        {
            get; set;
        }

        private List<string> data
        {
            get; set;
        }

        public JokesDTO(string status, string total, string end_point, string method, List<string> data)
        {

            this.status = status;
            this.total = total;
            this.end_point = end_point;
            this.method = method;
            this.data = data;

        }

        public JokesDTO() { }
    }
}
