using SalesFlow.Core.Entities;

namespace SalesFlow.Core.Interfaces;
public interface ILeadRepository
{
	Task<Lead?> GetByIdAsync(int Id);
	Task<List<Lead>> GetAllAsync();
	Task<Lead> AddAsync(Lead lead);
	Task UpdateAsync(Lead lead);
	Task DeleteAsync(int Id);
}