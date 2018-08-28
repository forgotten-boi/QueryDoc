using System;
using System.Threading.Tasks;
using Abp.TestBase;
using CBT.OnlineTutor.EntityFrameworkCore;
using CBT.OnlineTutor.Tests.TestDatas;

namespace CBT.OnlineTutor.Tests
{
    public class OnlineTutorTestBase : AbpIntegratedTestBase<OnlineTutorTestModule>
    {
        public OnlineTutorTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<OnlineTutorDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<OnlineTutorDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<OnlineTutorDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<OnlineTutorDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<OnlineTutorDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<OnlineTutorDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<OnlineTutorDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<OnlineTutorDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
