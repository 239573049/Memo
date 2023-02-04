using FreeSql.DataAnnotations;

namespace Memo.Service.Memo;

public abstract class EntityBase
{
    [Column(IsIdentity = true, IsPrimary = true)]
    public Guid Id { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime CreationdTime { get; set; }
}
