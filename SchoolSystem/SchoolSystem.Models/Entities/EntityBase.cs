using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Domain.Entities;

public abstract class EntityBase
{
    protected EntityBase() { }

    public EntityBase(DateTime? createdDate)
    {
        CreatedDateTime = createdDate ?? throw new ArgumentNullException(nameof(createdDate));
    }

    public int Id { get; }

    public DateTime CreatedDateTime { get; } = default!;

    public DateTime ModifiedDateTime { get; } = default!;

    //TODO: Add Created and Modified UserId after creating User entity

}



