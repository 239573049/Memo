namespace Memo.Service.Memo;

public class Info : EntityBase
{
    /// <summary>
    /// 名称
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// 头像
    /// </summary>
    public string Avatar { get; set; }

    /// <summary>
    /// 邮箱
    /// </summary>
    public  string EMail { get; set; }
}
