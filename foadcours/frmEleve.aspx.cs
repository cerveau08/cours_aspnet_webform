using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using foadcours.Models;

namespace foadcours
{
    public partial class frmEleve : System.Web.UI.Page
    {
        bdEtablissementEntities db = new bdEtablissementEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            dgEleve.DataSource = db.Eleve.ToList();
            dgEleve.DataBind();
            ddlService.DataSource = db.Service.ToList();
            ddlService.DataValueField = "Id";
            ddlService.DataTextField = "Libelle";
            ddlService.DataBind();
        }

        protected void btnEnregistrer_Click(object sender, EventArgs e)
        {
            Eleve el = new Eleve();
            el.IdService = int.Parse(ddlService.SelectedValue);
            el.NomPrenomEleve = txtNomPrenom.Text;
            el.EmailEleve = txtEmail.Text;
            el.AdresseEleve = txtAdresse.Text;
            db.Eleve.Add(el);
            db.SaveChanges();
            Server.Transfer("frmEleve.aspx");
        }

        protected void btnRechercher_Click(object sender, EventArgs e)
        {
            var liste = db.Eleve.Join(db.Service, x => x.IdService, y => y.ID, (x, y) =>
            new { x.IdEleve, x.NomPrenomEleve, x.EmailEleve, x.AdresseEleve, y.Libelle, y.ID }).ToList();

            if(!string.IsNullOrEmpty(txtNomPrenom.Text))
            {
                liste = liste.Where(a => a.NomPrenomEleve.ToUpper().Contains(txtNomPrenom.Text.ToUpper())).ToList();
            }

            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                liste = liste.Where(a => a.EmailEleve.ToUpper() == txtEmail.Text.ToUpper()).ToList();
            }

            if (!string.IsNullOrEmpty(txtAdresse.Text))
            {
                liste = liste.Where(a => a.AdresseEleve.ToUpper().Contains(txtAdresse.Text.ToUpper())).ToList();
            }

            if (!string.IsNullOrEmpty(ddlService.Text))
            {
                int i = int.Parse(ddlService.Text);
                liste = liste.Where(a => a.ID == i).ToList();
            }

            dgEleve.DataSource = liste;
            dgEleve.DataBind();
            ddlService.DataSource = db.Service.ToList();
            ddlService.DataValueField = "Id";
            ddlService.DataTextField = "Libelle";
            ddlService.DataBind();
        }

        protected void btnSupprimer_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgEleve.SelectedRow.Cells[1].Text);
            Eleve el = db.Eleve.Find(id);
            db.Eleve.Remove(el);
            db.SaveChanges();
            Server.Transfer("FrmEleve.aspx");
        }

        protected void btnModifier_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgEleve.SelectedRow.Cells[1].Text);
            Eleve el = db.Eleve.Find(id);
            el.IdService = int.Parse(ddlService.SelectedValue);
            el.NomPrenomEleve = txtNomPrenom.Text;
            el.EmailEleve = txtEmail.Text;
            el.AdresseEleve = txtAdresse.Text;
            db.SaveChanges();
            Server.Transfer("frmEleve.aspx");
        }

        protected void dgEleve_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNomPrenom.Text = HttpUtility.HtmlEncode(dgEleve.SelectedRow.Cells[2].Text);
            txtEmail.Text = dgEleve.SelectedRow.Cells[3].Text;
            txtAdresse.Text = dgEleve.SelectedRow.Cells[4].Text;
            ddlService.SelectedValue = dgEleve.SelectedRow.Cells[5].Text;
        }
    }
}