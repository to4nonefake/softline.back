using softline.core.Interfaces;
using softline.db.Context;
using softline.db.Model;
using System.Collections.Generic;
using System.Linq;

namespace softline.core.Services {
    public class StatusesServices : IStatusesServices {

        private ObjectivesContext _context;

        public StatusesServices(ObjectivesContext context) {
            _context = context;
        }

        public List<Status> GetStatuses() {
            return _context.Statuses.ToList();
        }
    }
}
