using MemberRegistration.Business.Abstract;
using MemberRegistration.Business.DependencyResolvers.Ninject;
using MemberRegistration.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistration.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var memberService = InstanceFactory.GetInstance<IMemberService>();
            memberService.Add(new Member
            {
                Email ="cpt.mfs@gmail.com",
                FirstName = "Muhammed Ferit",
                LastName = "Şimşek",
                DateOfBirth = new DateTime(1995, 6, 6),
                TcNo = "21310516234"
            });
            Console.WriteLine("Eklendi");
            Console.ReadLine();


        }
    }
}
