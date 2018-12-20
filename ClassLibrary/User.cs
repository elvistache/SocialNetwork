using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public struct Post
{
    public string Title;
    public string Content;
}

namespace ClassLibrary
{
    public enum Rank { Begginer, Member, SuperUser, HeroUser, GoldUser, RoyalUser }
    public class User : Person
    {
        public string Email { get; private set; }
        public int Id { get; private set; }
        public Rank Rank { get; private set; }
        public List<Post> Catalog { get; private set; }

        public User(string email, int id, Rank rank, List<Post> catalog, string firstName, string lastName, DateTime birthDate, Gender gender) : base(firstName, lastName, birthDate, gender)
        {
            this.Email = email;
            this.Id = id;
            this.Rank = rank;
            this.Catalog = catalog;
        }

       
    }
    }
