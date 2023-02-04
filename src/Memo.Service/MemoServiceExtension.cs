using Memo.Service.Memo;

namespace Microsoft.Extensions.DependencyInjection;

public static class MemoServiceExtension
{
    /// <summary>
    /// 注入Memo Service
    /// </summary>
    /// <param name="services"></param>
    /// <param name="connectionString"></param>
    /// <returns></returns>
    public static IServiceCollection AddMemoService(this IServiceCollection services, string connectionString)
    {
        services.AddSingleton(new FreeSql.FreeSqlBuilder()
            .UseConnectionString(FreeSql.DataType.Sqlite, connectionString)
            .UseAutoSyncStructure(true) //自动同步实体结构到数据库
            .Build());

        var freeSql = services.BuildServiceProvider().CreateScope().ServiceProvider.GetService<IFreeSql>();

        freeSql.CodeFirst.SyncStructure(typeof(ToDo));//Topic 为要同步的实体类
        freeSql.CodeFirst.SyncStructure(typeof(ToDoGroup));//Topic 为要同步的实体类

        return services;
    }
}
