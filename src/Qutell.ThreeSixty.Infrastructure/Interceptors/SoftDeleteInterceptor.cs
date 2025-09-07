using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Qutell.ThreeSixty.Domain.Entities.Lookups;
using System;

public class SoftDeleteInterceptor : SaveChangesInterceptor
{
	public override InterceptionResult<int> SavingChanges(DbContextEventData eventData,
        InterceptionResult<int> result)
    {
        var context = eventData.Context;
        if (context == null) return base.SavingChanges(eventData, result);
        foreach (var entry in context.ChangeTracker.Entries())
        {
           
                if (entry.State == EntityState.Deleted&&entry.Entity is ISoftDelete softDeletable)
                {
                    entry.State = EntityState.Modified;
                    softDeletable.IsDeleted = true;

            }
            
        }
        return base.SavingChanges(eventData, result);
    }
}
