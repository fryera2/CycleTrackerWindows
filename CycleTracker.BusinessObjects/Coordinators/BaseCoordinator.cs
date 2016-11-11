using CycleTracker.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleTracker.BusinessObjects
{
    public abstract class BaseCoordinator
    {
        private DatabaseCoordinator _dbCoordinator = null;

        /// <summary>
        /// Holds an instance of the database coordinator
        /// </summary>
        protected DatabaseCoordinator DatabaseCoordinator
        {
            get
            {
                if (_dbCoordinator == null)
                {
                    _dbCoordinator = new DatabaseCoordinator();
                }
                return _dbCoordinator;
            }    
        }

    }
}
