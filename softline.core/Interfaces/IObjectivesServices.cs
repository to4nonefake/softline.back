using softline.db.Model;
using System.Collections.Generic;

namespace softline.core.Interfaces {
    public interface IObjectivesServices {

        List<Objective> GetObjectives();

        Objective GetObjective(int id);

        Objective CreateObjective(Objective obj);

        void DeleteObjective(Objective obj);

        Objective EditObjective(Objective obj);
    }
}
