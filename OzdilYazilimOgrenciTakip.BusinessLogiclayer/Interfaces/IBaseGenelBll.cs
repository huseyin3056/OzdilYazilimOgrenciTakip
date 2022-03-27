using OzdilYazilimOgrenciTakip.Model.Entities.Base;

namespace OzdilYazilimOgrenciTakip.BusinessLogiclayer.Interfaces
{
    public interface IBaseGenelBll // Dto kullanılmadığında kullanılıyor
    {
        bool Insert(BaseEntity entity);
        bool Update(BaseEntity oldEntity, BaseEntity currentEntity);
        string YeniKodVer();


    }
}
