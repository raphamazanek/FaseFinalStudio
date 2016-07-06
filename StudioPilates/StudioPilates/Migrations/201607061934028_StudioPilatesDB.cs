namespace StudioPilates.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudioPilatesDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Agenda",
                c => new
                    {
                        AgendaId = c.Int(nullable: false, identity: true),
                        Aula = c.String(),
                        DataInicio = c.String(),
                        DataFinal = c.String(),
                        Instrutor = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AgendaId);
            
            CreateTable(
                "dbo.Alunos",
                c => new
                    {
                        AlunoId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Sobrenome = c.String(),
                        CPF = c.String(),
                        DtNasc = c.String(),
                        Celular = c.String(),
                        Telefone = c.String(),
                        AvaliacaoFisica = c.String(),
                        Endereco = c.String(),
                        Email = c.String(),
                        Plano = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AlunoId);
            
            CreateTable(
                "dbo.AlunoAgenda",
                c => new
                    {
                        AlunoAgendaID = c.Int(nullable: false, identity: true),
                        Agenda = c.String(),
                        Aluno = c.String(),
                    })
                .PrimaryKey(t => t.AlunoAgendaID);
            
            CreateTable(
                "dbo.Instrutor",
                c => new
                    {
                        InstrutorId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Sobrenome = c.String(),
                        CPF = c.String(),
                        DtNasc = c.String(),
                        Celular = c.String(),
                        Telefone = c.String(),
                        Endereco = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.InstrutorId);
            
            CreateTable(
                "dbo.Plano",
                c => new
                    {
                        PlanoId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.PlanoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Plano");
            DropTable("dbo.Instrutor");
            DropTable("dbo.AlunoAgenda");
            DropTable("dbo.Alunos");
            DropTable("dbo.Agenda");
        }
    }
}
