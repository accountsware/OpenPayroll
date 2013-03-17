using System;

namespace K.Common.Patterns
{
    public interface IBaseModel
    {
        int Id { get; set; }

        byte RowStatus { get; set; }

        byte[] RowVersion { get; set; }

        DateTime CreatedDate { get; set; }
		
		string CreatedBy { get; set; }
        
		string ModifiedBy { get; set; }

        DateTime? ModifiedDate { get; set; }

        byte CrudStatus { get; set; }
    }
}
