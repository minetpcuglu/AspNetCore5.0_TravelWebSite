using BusinessLayer.Services.Interface;
using DataAccessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.Concrete
{
    public class AboutService: IAboutService //**generic yapıyı ekle.
    {
        private readonly IAboutDal _aboutDal;

        public AboutService(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void test1()
        {
            throw new NotImplementedException();
        }
    }
}
