using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vocabook.AppData.Entities;
using Vocabook.AppLib.Tools;

namespace Vocabook.AppData.Configuration
{
    public class WordConfig : IEntityTypeConfiguration<WordEntity>
    {
        public void Configure(EntityTypeBuilder<WordEntity> builder)
        {
            builder.ToTable("WordList");
            builder.HasKey(k => k.English);            
            builder.Property(p => p.Sample).IsRequired(false);
            builder.Property(p => p.Synonym).IsRequired(false);
            builder.Property(p => p.Created).IsRequired(true);
        }

        
        // Default value setting is removed to OnModelCreating         
        // public void Configure(EntityTypeBuilder<Word> builder)
        // {
        //    AppDbContext context = Services.GetServiceInstance<AppDbContext>();

        //    string defaultCurrentDateSql = context.Database.ProviderName switch
        //    {
        //        "Microsoft.EntityFrameworkCore.SqlServer" => "getutcdate()",
        //        "Microsoft.EntityFrameworkCore.Sqlite" => "datetime('now', 'utc')",
        //        // https://docs.microsoft.com/tr-tr/ef/core/providers/?tabs=dotnet-core-cli
        //        _ => ""
        //    };
        //    ...
        // }
    }
}
