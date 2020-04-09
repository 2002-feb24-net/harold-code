using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotesService.Api.Models;

namespace NotesService.Api.Repositories
{
    public class NoteRepository : INoteRepository
    {
        private readonly List<Note> _data = new List<Note>
        {
            new Note {
                Id = 1,
                Author = "Nick",
                IsPublic = true,
                Text = "REST stands for representational state transfer"
            }

        };

        public IEnumerable<Note> GetAll()
        {
            return _data.ToList();
        }

        public Note GetById(int id)
        {
            return _data.FirstOrDefault(n => n.Id == id);
        }

        public void Add(Note note)
        {
            note.Id = _data.Max(n => n.Id) + 1;
            _data.Add(note);
        }

        /// <summary>
        /// Removes an element from the persistent list
        /// </summary>
        /// <param name="note">note object to be deleted</param>
        public void Remove(int id)
        {
            /*var note = _data[id];*/
            var note = GetById(id);
            _data.Remove(note);
        }

        /// <summary>
        /// Updates an element from the persistent list
        /// </summary>
        /// <param name="note">note object data to overwrite object in list</param>
        /// <param name="id">id of note object to be replaced in the list</param>
        public void Update(int id, Note note)
        {
            var NoteTobeUpdated = GetById(id);

            NoteTobeUpdated.Author = note.Author;
            NoteTobeUpdated.Text = note.Text;
            NoteTobeUpdated.IsPublic = note.IsPublic;

        }
    }
}
