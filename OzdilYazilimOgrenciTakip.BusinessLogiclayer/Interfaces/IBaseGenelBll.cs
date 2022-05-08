using OzdilYazilimOgrenciTakip.Model.Entities.Base;

namespace OzdilYazilimOgrenciTakip.BusinessLogiclayer.Interfaces
{
    public interface IBaseGenelBll // Insert,Update için paremetre  kullanılmadığında kullanılıyor
    {
        bool Insert(BaseEntity entity);
        bool Update(BaseEntity oldEntity, BaseEntity currentEntity);
        string YeniKodVer();


    }
}
