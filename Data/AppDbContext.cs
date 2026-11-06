using Microsoft.EntityFrameworkCore;
using HimeraLab.Entities;
using Action = HimeraLab.Entities.Action;

namespace HimeraLab.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    
    public DbSet<Creature> Creatures { get; set; }
    public DbSet<CreatureType> CreatureTypes { get; set; }
    public DbSet<Language> Languages { get; set; }
    public DbSet<SavingThrow> SavingThrows { get; set; }
    public DbSet<Skill> Skills { get; set; }
    public DbSet<SpeedType> SpeedTypes { get; set; }
    public DbSet<Action> Actions { get; set; }
    public DbSet<Feat> Feats { get; set; }
    public DbSet<DamageType> DamageTypes { get; set; }
    public DbSet<Attack> Attacks { get; set; }
    
    public DbSet<LanguageCreature> LanguageCreatures { get; set; }
    public DbSet<SavingThrowCreature> SavingThrowCreatures { get; set; }
    public DbSet<SkillCreature> SkillCreatures { get; set; }
    public DbSet<SpeedCreature> SpeedCreatures { get; set; }
    public DbSet<ActionCreature> ActionCreatures { get; set; }
    public DbSet<CreatureFeat> CreatureFeats { get; set; }
    
    public DbSet<Role> Roles { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Saved> SavedItems { get; set; }
    
    public DbSet<GenerationTable> GenerationTables { get; set; }
    public DbSet<GenerationTableCreature> GenerationTableCreatures { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<LanguageCreature>()
            .HasKey(lc => new { lc.IdCreature, lc.IdLanguage });

        modelBuilder.Entity<SavingThrowCreature>()
            .HasKey(sc => new { sc.IdCreature, sc.IdSave });

        modelBuilder.Entity<SkillCreature>()
            .HasKey(sc => new { sc.IdCreature, sc.IdSkill });

        modelBuilder.Entity<SpeedCreature>()
            .HasKey(sc => new { sc.IdCreature, sc.IdSpeed });

        modelBuilder.Entity<ActionCreature>()
            .HasKey(ac => new { ac.IdCreature, ac.IdAction });

        modelBuilder.Entity<CreatureFeat>()
            .HasKey(cf => new { cf.IdCreature, cf.IdFeat });

        modelBuilder.Entity<GenerationTableCreature>()
            .HasKey(gtc => new { gtc.IdTable, gtc.IdCreature });

        modelBuilder.Entity<Saved>()
            .HasOne(s => s.User)
            .WithMany(u => u.SavedItems)
            .HasForeignKey(s => s.IdUser)
            .OnDelete(DeleteBehavior.Cascade);

        // Существа в сохранениях. Если удалить базовое существо из справочника, 
        // мы не должны удалять пользовательское сохранение (Restrict).
        modelBuilder.Entity<Saved>()
            .HasOne(s => s.Hybrid)
            .WithMany()
            .HasForeignKey(s => s.IdHybrid)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Saved>()
            .HasOne(s => s.Base)
            .WithMany()
            .HasForeignKey(s => s.IdBase)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Saved>()
            .HasOne(s => s.Donor)
            .WithMany()
            .HasForeignKey(s => s.IdDonor)
            .OnDelete(DeleteBehavior.Restrict);

        // Атаки. Если удалить существо, его атаки удаляются
        modelBuilder.Entity<Attack>()
            .HasOne(a => a.Creature)
            .WithMany(c => c.Attacks)
            .HasForeignKey(a => a.IdCreature)
            .OnDelete(DeleteBehavior.Cascade);


        // --- УНИКАЛЬНЫЕ ИНДЕКСЫ ---
        // Логин пользователя не должен повторяться
        modelBuilder.Entity<User>()
            .HasIndex(u => u.Login)
            .IsUnique();

        // Роли не должны повторяться
        modelBuilder.Entity<Role>()
            .HasIndex(r => r.Name)
            .IsUnique();

        // Диапазон в таблице генерации не должен пересекаться
        modelBuilder.Entity<GenerationTableCreature>()
            .HasIndex(gtc => new { gtc.IdTable, gtc.RangeMin })
            .IsUnique();


        // --- НАЧАЛЬНЫЕ ДАННЫЕ (SEED DATA) ---
        // Заполняем базовые роли при создании БД
        modelBuilder.Entity<Role>().HasData(
            new Role { Id = 1, Name = "user" },
            new Role { Id = 2, Name = "admin" }
        );
    }
}