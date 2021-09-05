using softline.core.Interfaces;
using softline.db.Context;
using softline.db.Model;
using System.Collections.Generic;
using System.Linq;

namespace softline.core.Services {
    public class ObjectivesServices : IObjectivesServices {

        private ObjectivesContext _context;

        public ObjectivesServices(ObjectivesContext context) {
            _context = context;
        }

        public List<Objective> GetObjectives() {

            return _context.Objectives.ToList();
        }

        public Objective GetObjective(int id) {
            return _context.Objectives.FirstOrDefault(obj => obj.id == id);
        }

        public Objective CreateObjective(Objective obj) {
            _context.Add(obj);
            _context.SaveChanges();

            return obj;
        }

        public void DeleteObjective(Objective obj) {
            try {
                _context.Objectives.Remove(obj);
                _context.SaveChanges();
            } catch {

            }
        }

        public Objective EditObjective(Objective obj) {
            var dbObjective = _context.Objectives.FirstOrDefault(e => e.id == obj.id);
            dbObjective.name = obj.name;
            dbObjective.description = obj.description;
            dbObjective.status_id = obj.status_id;
            _context.SaveChanges();
            return dbObjective;
        }
    }
}
