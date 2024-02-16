namespace SistemaFinanceiro.Interfaces.Generics;

public interface InterfaceGeneric<T> where T : class
{
    Task Add(T objcet);
    Task Update(T objcet);
    Task Delete(T objcet);
    Task<T> GetById(int Id);
    Task<IEnumerable<T>> GetAll();
}