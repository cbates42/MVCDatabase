using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.EnterpriseServices;
using System.Net;
using System.Web.Mvc;

namespace MVCDatabase.Services
{
    public class Services
    {
        private PROG455SP23Entities db = new PROG455SP23Entities();

        public List<Character> GetCharacters()
        {
            return db.Characters.ToList();
        }

        public void AddCharacter(Character character)
        {
            db.Characters.Add(character);
            db.SaveChanges();
        }    

        public Character FindCharacter(int? id)
        {
            if (id != null)
            {
                Character character = db.Characters.Find(id);
                return character;
            }

            else
            {
                return null;
            }
        }

        public void DeleteCharacter(int id)
        {
            var character = db.Characters.Find(id);
            db.Characters.Remove(character);
            db.SaveChanges();
        }
    }
}