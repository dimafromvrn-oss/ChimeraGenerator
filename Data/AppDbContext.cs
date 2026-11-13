using HimeraLab.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace ChimeraLab.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    
    public DbSet<Creature> Creatures { get; set; }
    public DbSet<CreatureType> CreatureTypes { get; set; }
    public DbSet<Language> Languages { get; set; }
    public DbSet<LanguageCreature> LanguageCreatures { get; set; }
    public DbSet<SavingThrow> SavingThrows { get; set; }
    public DbSet<SavingThrowCreature> SavingThrowCreatures { get; set; }
    public DbSet<Skill> Skills { get; set; }
    public DbSet<SkillCreature> SkillCreatures { get; set; }
    public DbSet<SpeedType> SpeedTypes { get; set; }
    public DbSet<SpeedCreature> SpeedCreatures { get; set; }
    public DbSet<GameAction> GameActions { get; set; }
    public DbSet<ActionCreature> ActionCreatures { get; set; }
    public DbSet<Feat> Feats { get; set; }
    public DbSet<CreatureFeat> CreatureFeats { get; set; }
    public DbSet<Attack> Attacks { get; set; }
    public DbSet<DamageType> DamageTypes { get; set; }
    
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Saved> SavedItems { get; set; }
    
    public DbSet<GenerationTable> GenerationTables { get; set; }
    public DbSet<GenerationTableCreature> GenerationTableCreatures { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Creature>(entity =>
        {
            entity.ToTable("Creatures");
            entity.Property(e => e.Id).HasColumnName("id_creature");
            entity.Property(e => e.Name).HasColumnName("Name").HasColumnType("VARCHAR(50)");
            entity.Property(e => e.Size).HasColumnName("Size").HasColumnType("VARCHAR(20)");
            entity.Property(e => e.AC).HasColumnName("AC");
            entity.Property(e => e.HP).HasColumnName("HP");
            entity.Property(e => e.HPFormula).HasColumnName("HP_formula").HasColumnType("VARCHAR(20)");
            entity.Property(e => e.CR).HasColumnName("CR");
            entity.Property(e => e.Strength).HasColumnName("Strength").HasColumnType("SMALLINT");
            entity.Property(e => e.Dexterity).HasColumnName("Dexterity").HasColumnType("SMALLINT");
            entity.Property(e => e.Constitution).HasColumnName("Constitution").HasColumnType("SMALLINT");
            entity.Property(e => e.Intelligence).HasColumnName("Intelligence").HasColumnType("SMALLINT");
            entity.Property(e => e.Wisdom).HasColumnName("Wisdom").HasColumnType("SMALLINT");
            entity.Property(e => e.Charisma).HasColumnName("Charisma").HasColumnType("SMALLINT");
            entity.Property(e => e.ProficiencyBonus).HasColumnName("ProficiencyBonus").HasColumnType("SMALLINT"); // Исправлено!
            entity.Property(e => e.IdType).HasColumnName("id_type");
        });

        modelBuilder.Entity<CreatureType>(entity => { entity.ToTable("Creature_types"); entity.Property(e => e.Id).HasColumnName("id_type"); entity.Property(e => e.Name).HasColumnName("Name").HasColumnType("VARCHAR(20)"); });
        modelBuilder.Entity<Language>(entity => { entity.ToTable("Languages"); entity.Property(e => e.Id).HasColumnName("id_language"); entity.Property(e => e.Name).HasColumnName("Name").HasColumnType("VARCHAR(40)"); });
        modelBuilder.Entity<LanguageCreature>(entity => { entity.ToTable("Languages_Creatures"); entity.Property(e => e.Id).HasColumnName("id"); entity.Property(e => e.IdLanguage).HasColumnName("id_language"); entity.Property(e => e.IdCreature).HasColumnName("id_creature"); entity.Property(e => e.CanSpeak).HasColumnName("Can_speak"); });
        modelBuilder.Entity<Attack>(entity => { entity.ToTable("Attacks"); entity.Property(e => e.Id).HasColumnName("id_attack"); entity.Property(e => e.AttackBonus).HasColumnName("Attack_bonus"); entity.Property(e => e.Damage).HasColumnName("Damage").HasColumnType("VARCHAR(20)"); entity.Property(e => e.Description).HasColumnName("Description").HasColumnType("VARCHAR(255)"); entity.Property(e => e.Characteristic).HasColumnName("Characteristic").HasColumnType("VARCHAR(20)"); entity.Property(e => e.IdCreature).HasColumnName("id_creature"); entity.Property(e => e.Name).HasColumnName("Name").HasColumnType("VARCHAR(40)"); entity.Property(e => e.IdDamage).HasColumnName("id_damage"); });
        modelBuilder.Entity<User>(entity => { entity.ToTable("Users"); entity.Property(e => e.Id).HasColumnName("id_user"); entity.Property(e => e.Login).HasColumnName("Login").HasColumnType("VARCHAR(100)"); entity.Property(e => e.PasswordHash).HasColumnName("Password_hash").HasColumnType("VARCHAR(255)"); entity.Property(e => e.IdRole).HasColumnName("id_role"); });
        modelBuilder.Entity<Role>(entity => { entity.ToTable("Roles"); entity.Property(e => e.Id).HasColumnName("id_role"); entity.Property(e => e.Name).HasColumnName("Name").HasColumnType("VARCHAR(20)"); });
        modelBuilder.Entity<Saved>(entity => { entity.ToTable("Saved"); entity.Property(e => e.Id).HasColumnName("id_saved"); entity.Property(e => e.IdHybrid).HasColumnName("id_hybrid"); entity.Property(e => e.IdBase).HasColumnName("id_base"); entity.Property(e => e.IdDonor).HasColumnName("id_donor"); entity.Property(e => e.IdUser).HasColumnName("id_user"); });
        modelBuilder.Entity<GameAction>(entity => { entity.ToTable("Actions"); entity.Property(e => e.Id).HasColumnName("id_action"); entity.Property(e => e.Name).HasColumnName("Name").HasColumnType("VARCHAR(40)"); entity.Property(e => e.Description).HasColumnName("Description").HasColumnType("VARCHAR(255)"); });
        modelBuilder.Entity<ActionCreature>(entity => { entity.ToTable("Actions_Creatures"); entity.Property(e => e.Id).HasColumnName("id"); entity.Property(e => e.IdAction).HasColumnName("id_action"); entity.Property(e => e.IdCreature).HasColumnName("id_creature"); });
        modelBuilder.Entity<Skill>(entity => { entity.ToTable("Skills"); entity.Property(e => e.Id).HasColumnName("id_skill"); entity.Property(e => e.Name).HasColumnName("Name").HasColumnType("VARCHAR(30)"); entity.Property(e => e.RelatedCharacteristic).HasColumnName("Related_characteristic").HasColumnType("VARCHAR(20)"); });
        modelBuilder.Entity<SkillCreature>(entity => { entity.ToTable("Skills_Creatures"); entity.Property(e => e.Id).HasColumnName("id"); entity.Property(e => e.IdSkill).HasColumnName("id_skill"); entity.Property(e => e.IdCreature).HasColumnName("id_creature"); entity.Property(e => e.DoubleProficiency).HasColumnName("Double_proficiency"); });
        modelBuilder.Entity<SavingThrow>(entity => { entity.ToTable("Saving_throws"); entity.Property(e => e.Id).HasColumnName("id_save"); entity.Property(e => e.Name).HasColumnName("Name").HasColumnType("VARCHAR(20)"); });
        modelBuilder.Entity<SavingThrowCreature>(entity => { entity.ToTable("Saving_throws_creatures"); entity.Property(e => e.Id).HasColumnName("id"); entity.Property(e => e.IdSave).HasColumnName("id_save"); entity.Property(e => e.IdCreature).HasColumnName("id_creature"); });
        modelBuilder.Entity<SpeedType>(entity => { entity.ToTable("Speed"); entity.Property(e => e.Id).HasColumnName("id_speed"); entity.Property(e => e.TypeSpeed).HasColumnName("Type_speed").HasColumnType("VARCHAR(20)"); });
        modelBuilder.Entity<SpeedCreature>(entity => { entity.ToTable("Speed_Creatures"); entity.Property(e => e.Id).HasColumnName("id"); entity.Property(e => e.IdSpeed).HasColumnName("id_speed"); entity.Property(e => e.IdCreature).HasColumnName("id_creature"); entity.Property(e => e.Value).HasColumnName("Value"); });
        modelBuilder.Entity<Feat>(entity => { entity.ToTable("Feats"); entity.Property(e => e.Id).HasColumnName("id_feat"); entity.Property(e => e.Name).HasColumnName("Name").HasColumnType("VARCHAR(50)"); entity.Property(e => e.Description).HasColumnName("Description").HasColumnType("VARCHAR(255)"); });
        modelBuilder.Entity<CreatureFeat>(entity => { entity.ToTable("Creatures_Feats"); entity.Property(e => e.Id).HasColumnName("id"); entity.Property(e => e.IdCreature).HasColumnName("id_creature"); entity.Property(e => e.IdFeat).HasColumnName("id_feat"); entity.Property(e => e.FeatType).HasColumnName("Feat_type").HasColumnType("VARCHAR(30)"); });
        modelBuilder.Entity<DamageType>(entity => { entity.ToTable("Damage_types"); entity.Property(e => e.Id).HasColumnName("id_damage"); entity.Property(e => e.Name).HasColumnName("Name").HasColumnType("VARCHAR(30)"); });
        modelBuilder.Entity<GenerationTable>(entity => { entity.ToTable("Generation_tables"); entity.Property(e => e.Id).HasColumnName("id_table"); entity.Property(e => e.Name).HasColumnName("Name").HasColumnType("VARCHAR(50)"); });
        modelBuilder.Entity<GenerationTableCreature>(entity => { entity.ToTable("Generation_tables_Creatures"); entity.Property(e => e.Id).HasColumnName("id"); entity.Property(e => e.IdTable).HasColumnName("id_table"); entity.Property(e => e.IdCreature).HasColumnName("id_creature"); entity.Property(e => e.RangeMin).HasColumnName("Range_min"); entity.Property(e => e.RangeMax).HasColumnName("Range_max"); });
        
        
        
        modelBuilder.Entity<LanguageCreature>().HasIndex(x => new { x.IdCreature, x.IdLanguage }).IsUnique();
        modelBuilder.Entity<SkillCreature>().HasIndex(x => new { x.IdCreature, x.IdSkill }).IsUnique();
        modelBuilder.Entity<SavingThrowCreature>().HasIndex(x => new { x.IdCreature, x.IdSave }).IsUnique();
        modelBuilder.Entity<SpeedCreature>().HasIndex(x => new { x.IdCreature, x.IdSpeed }).IsUnique();
        modelBuilder.Entity<ActionCreature>().HasIndex(x => new { x.IdCreature, x.IdAction }).IsUnique();
        modelBuilder.Entity<CreatureFeat>().HasIndex(x => new { x.IdCreature, x.IdFeat }).IsUnique();
        modelBuilder.Entity<GenerationTableCreature>().HasIndex(x => new { x.IdTable, x.IdCreature }).IsUnique();
        modelBuilder.Entity<User>().HasIndex(u => u.Login).IsUnique();
        
        modelBuilder.Entity<Creature>()
            .HasOne<CreatureType>()
            .WithMany()
            .HasForeignKey(c => c.IdType);
        
        modelBuilder.Entity<Saved>()
            .HasOne<User>()
            .WithMany(u => u.SavedItems) // Явно указываем навигацию
            .HasForeignKey(s => s.IdUser)
            .OnDelete(DeleteBehavior.Cascade);
        
        modelBuilder.Entity<Saved>().HasOne<Creature>().WithMany().HasForeignKey(s => s.IdHybrid).OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Saved>().HasOne<Creature>().WithMany().HasForeignKey(s => s.IdBase).OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Saved>().HasOne<Creature>().WithMany().HasForeignKey(s => s.IdDonor).OnDelete(DeleteBehavior.Restrict);
        
        modelBuilder.Entity<Creature>().HasMany(c => c.Attacks).WithOne().HasForeignKey(a => a.IdCreature).OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Creature>().HasMany(c => c.LanguageCreatures).WithOne().HasForeignKey(lc => lc.IdCreature).OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Creature>().HasMany(c => c.SkillCreatures).WithOne().HasForeignKey(sc => sc.IdCreature).OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Creature>().HasMany(c => c.SavingThrowCreatures).WithOne().HasForeignKey(sc => sc.IdCreature).OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Creature>().HasMany(c => c.SpeedCreatures).WithOne().HasForeignKey(sc => sc.IdCreature).OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Creature>().HasMany(c => c.ActionCreatures).WithOne().HasForeignKey(ac => ac.IdCreature).OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Creature>().HasMany(c => c.CreatureFeats).WithOne().HasForeignKey(cf => cf.IdCreature).OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Creature>().HasMany(c => c.GenerationTableCreatures).WithOne().HasForeignKey(gtc => gtc.IdCreature).OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<GenerationTable>()
            .HasMany(gt => gt.Entries)
            .WithOne()
            .HasForeignKey(gtc => gtc.IdTable)
            .OnDelete(DeleteBehavior.Cascade);
        
        modelBuilder.Entity<Role>().HasData(
            new Role { Id = Guid.Parse("11111111-1111-1111-1111-111111111111"), Name = "user" },
            new Role { Id = Guid.Parse("22222222-2222-2222-2222-222222222222"), Name = "admin" }
        );
    }
}