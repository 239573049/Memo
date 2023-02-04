using FreeSql.DataAnnotations;
using System.Text.Json;

namespace Memo.Service.Memo;

public class ToDo : EntityBase
{
    /// <summary>
    /// 标题
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// 备注
    /// </summary>
    public string Remark { get; set; }

    [Column(MapType = typeof(string))]
    private string values { get; set; }

    /// <summary>
    /// 备注数据
    /// </summary>
    public List<ToDoValue> Values
    {
        get => JsonSerializer.Deserialize<List<ToDoValue>>(values) ?? new List<ToDoValue>();
        set => values = JsonSerializer.Serialize(value);
    }

    /// <summary>
    /// 是否重要
    /// </summary>
    public bool Importance { get; set; }

    /// <summary>
    /// 提醒时间
    /// </summary>
    public DateTime? ReminderTime { get; set; }

    public Guid GroupId { get; set; }
}
