using System.Security.Policy;

namespace LANraragi_Plus
{
	public static class RoleNames
	{
		/// <summary>
		/// 超级管理员
		/// </summary>
		/// <remarks>
		/// 网站最高管理者
		/// 拥有一切管理权限
		/// </remarks>
		public const string SuperAdministrator = nameof(SuperAdministrator);

		/// <summary>
		/// 网站管理员
		/// </summary>
		/// <remarks>
		/// 网站管理员，可以任命站点编辑者，不可以任命其他管理员
		/// </remarks>
		public const string Admin = nameof(Admin);

		/// <summary>
		/// 站点编辑者
		/// </summary>
		/// <remarks>
		/// 可以编辑网站内容，漫画条目内容，评论内容，但不能管理用户
		/// </remarks>
		public const string SiteEditor = nameof(SiteEditor);

		/// <summary>
		/// 初次注册新用户
		/// </summary>
		/// <remarks>
		/// 只有基本的浏览权限，仅可以查看非成人漫画
		/// </remarks>
		public const string UserLevel0 = nameof(UserLevel0);

		/// <summary>
		/// 注册一段时间的用户
		/// </summary>
		/// <remarks>
		/// 只有基本的浏览权限，可以查看全部的漫画
		/// </remarks>
		public const string UserLevel1 = nameof(UserLevel1);

		/// <summary>
		/// 老用户
		/// </summary>
		/// <remarks>
		/// 可以查看全部的漫画，可以编辑漫画Tag等基本信息
		/// </remarks>
		public const string UserLevel2 = nameof(UserLevel2);

		/// <summary>
		/// 付费用户
		/// </summary>
		/// <remarks>
		/// 直升UserLevel2
		/// </remarks>
		public const string VIPUser = nameof(VIPUser);
	}
}
