using Microsoft.EntityFrameworkCore;
using SalesFlow.Core.Entities;
using SalesFlow.Core.Interfaces;
using SalesFlow.Infrastructure.Data;

namespace SalesFlow.Infrastructure.Repositories;

public class LeadRepository : ILeadRepository
{
    private readonly AppDbContext _context;

    public LeadRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<List<Lead>> GetAllAsync()
    {
        return await _context.Leads.ToListAsync();
    }

    public async Task<Lead?> GetByIdAsync(int id)
    {
        return await _context.Leads.FindAsync(id);
    }

    public async Task<Lead> AddAsync(Lead lead)
    {
        _context.Leads.Add(lead);
        await _context.SaveChangesAsync();
        return lead;
    }
}