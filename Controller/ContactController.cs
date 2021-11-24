using AnnuaireWebSite.Data;
using AnnuaireWebSite.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnnuaireWebSite.Controller
{
    public class ContactController : ControllerBase
    {
        public List<Contact> contactsParam { get; set; }
        public List<Contact> contacts { get; set; }
        public async Task GetContactsByParameters(string first = null ,string last = null , string street =null , string city=null , int? zip=null)
        {
            contactsParam = await Api.GetContactsByParameters( first ,  last ,  street ,  city ,  zip) ;
        }
        public async Task GetContacts()
        {
            contacts = await Api.GetContacts();
        }
    }
}
