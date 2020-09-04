using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormsTest.Models;
using System.Data.Entity;
using System.Web.ModelBinding;
using Microsoft.Ajax.Utilities;
using System.Windows.Forms;

namespace WebFormsTest
{
    public partial class Payments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // Возвращаемый тип можно изменить на IEnumerable, однако для обеспечения поддержки
        // постраничного просмотра и сортировки необходимо добавить следующие параметры:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<WebFormsTest.Models.Payment> GetPayments([Control] DateTime? PayDateField, [Control] string customerName = "")
        {
            DefaultContext db = new DefaultContext();
            var query = db.Payments.Include(x => x.Customer);

            if (PayDateField.HasValue)
            {
                var payDateField = PayDateField.GetValueOrDefault();

                query = query.Where(x => x.PaymentDate.Day == payDateField.Day && x.PaymentDate.Month == payDateField.Month && x.PaymentDate.Year == payDateField.Year);
            }
            if (!string.IsNullOrWhiteSpace(customerName))
            {
                query = query.Where(x => x.Customer.CustomerName.Contains(customerName));
            }
                                    
            return query;
        }

        protected void FilterBtn_Click(object sender, EventArgs e)
        {
        }
    }
}