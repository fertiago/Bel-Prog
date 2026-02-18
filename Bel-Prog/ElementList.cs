using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Bel_Prog
{
    public class Element
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public int SecretNumber { get; set; }

        public Element(int id, string title, string name, int secretNumber)
        {
            Id = id;
            Title = title;
            Name = name;
            SecretNumber = secretNumber;
        }

        public override string ToString()
        {
            return $"{Title} {Name}";
        }
    }

    internal class ElementList
    {
        private List<Element> _list = new List<Element>();

        private int _nextId = 1;

        public int Add(string title, string name, int secretNumber)
        {
            var newElement = new Element(_nextId, title, name, secretNumber);
            _list.Add(newElement);
            _nextId++;
            return newElement.Id;
        }

        public Element GetById(int id)
        {
            return _list.FirstOrDefault(e => e.Id == id);
        }

        public bool Modifier(int id, string title, string name)
        {
            var element = _list.FirstOrDefault(e => e.Id == id);

            if (element != null)
            {
                element.Title = title;
                element.Name = name;
                return true;
            }
            return false;
        }

        public bool Remove(int id)
        {
            var element = _list.FirstOrDefault(e => e.Id == id);

            if (element != null)
            {
                _list.Remove(element);
                return true;
            }
            return false;
        }

        public List<Element> GetAll()
        {
            return _list;
        }

        public int Size()
        {
            return _list.Count;
        }

        public void Save(string pathFile)
        {
            using (StreamWriter sw = new StreamWriter(pathFile, false, Encoding.UTF8))
            {
                sw.WriteLine("Id;Qualite;Nom;SecretNumber");

                foreach (Element element in _list)
                {
                    sw.WriteLine($"{element.Id};{element.Title};{element.Name};{element.SecretNumber}");
                }
            }
        }

        public void Load(string pathFile)
        {
            if (!File.Exists(pathFile)) return;

            _list.Clear();
            string[] lignes = File.ReadAllLines(pathFile, Encoding.UTF8);

            for (int i = 1; i < lignes.Length; i++)
            {
                string ligne = lignes[i];
                if (string.IsNullOrWhiteSpace(ligne)) continue;

                string[] colonnes = ligne.Split(';');
                if (colonnes.Length >= 4)
                {
                    int id = int.Parse(colonnes[0]);
                    string titre = colonnes[1];
                    string nom = colonnes[2];
                    int secretNumber = int.Parse(colonnes[3]);

                    Element nouvelElement = new Element(id, titre, nom, secretNumber);
                    _list.Add(nouvelElement);
                }
            }

            if (_list.Count > 0)
            {
                _nextId = _list.Max(e => e.Id) + 1;
            }
            else
            {
                _nextId = 1;
            }
        }
    }
}