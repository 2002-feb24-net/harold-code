using NotesService.Api.Models;
using System.Collections.Generic;

namespace NotesService.Api.Repositories
{
    public interface INoteRepository
    {
        void Add(Note note);
        IEnumerable<Note> GetAll();
        Note GetById(int id);
        void Remove(int id);
        void Update(int id, Note note);
    }
}