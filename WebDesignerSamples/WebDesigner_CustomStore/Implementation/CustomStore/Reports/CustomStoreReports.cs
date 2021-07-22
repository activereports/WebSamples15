using System;
using System.Linq;

using GrapeCity.ActiveReports.PageReportModel;
using GrapeCity.ActiveReports.Aspnetcore.Designer;
using GrapeCity.ActiveReports.Aspnetcore.Designer.Services;

using WebDesignerCustomStore.Services;


namespace WebDesignerCustomStore.Implementation.CustomStore
{
	public partial class CustomStoreService : ICustomStoreService
	{
		#region IResourcesService implementation

		public IReportInfo[] GetReportsList()
		{
			return _db.GetReportsList()
					  .ToArray();
		}

		public Report GetReport(string id)
		{
			var report = _db.GetReport(id);

			if (report is null)
				throw new ReportNotFoundException();

			return report;
		}

		public string SaveReport(string id, Report report, bool isTemporary = false)
		{
			var reportId = Uri.UnescapeDataString(id);
			report.Name = reportId;

			var reportName = isTemporary ? Util.GenerateTempReportName() : reportId;
			reportId = string.Format("{0}{1}", isTemporary ? Util.TEMP_SUFFIX + "." : string.Empty, reportName);

			_db.SaveReport(reportName, report, isTemporary);
			return reportId;
		}

		public string UpdateReport(string id, Report report)
		{
			return SaveReport(id, report);
		}

		public void DeleteReport(string id)
		{
			_db.DeleteReport(id);
		}

		#endregion
	}
}