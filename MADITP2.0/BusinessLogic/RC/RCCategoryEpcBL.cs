using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADITP2._0.BusinessLogic.RC
{
    class RCCategoryEpcBL
    {
        private int mId;
        private string mDescription;
        private DateTime mCreatedAt;
        private DateTime mUpdatedAt;

        public int Id { get => mId; set => mId = value; }
        public string Description { get => mDescription; set => mDescription = value; }
        public DateTime CreatedAt { get => mCreatedAt; set => mCreatedAt = value; }
        public DateTime UpdatedAt { get => mUpdatedAt; set => mUpdatedAt = value; }
    }
}
