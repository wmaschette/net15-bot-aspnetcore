using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;
using MongoDB.Bson;

namespace SimpleBotCore.Logic
{
    public class SimpleBotUser
    {
        public string Reply(SimpleMessage message)
        {
            switch(message.Text.ToUpper())
            {
                case "OI":
                    return $"Oi {message.User}, tudo bem?";
                case "TUDO ÓTIMO E COM VOCÊ?":
                    return $"Estou bem também, pode me informar o seu cpf?";
                default:
                    var dados = new BsonDocument()
                    {
                        { "Usuario", message.User },
                        { "CPF", message.Text }
                    };
                    SalvarDados(dados);
                    return $"Obrigado pela informação {message.User}!";

            }
        }

        protected void SalvarDados(BsonDocument dados)
        {
            var client = new MongoClient("mongodb://localhost:27017");

            var db = client.GetDatabase("15net");
            var col = db.GetCollection<BsonDocument>("col01");

            var doc = new BsonDocument();

            col.InsertOne(dados);
        }

    }
}