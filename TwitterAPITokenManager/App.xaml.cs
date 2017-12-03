using System.IO;
using System.Windows;
using System.Xml.Serialization;
using TwitterAPITokenManager.Setting;
using TwitterAPITokenManager.Windows;

namespace TwitterAPITokenManager {
	/// <inheritdoc />
	/// <summary>
	/// App.xaml の相互作用ロジック
	/// </summary>
	public partial class App {

		#region Instance

		/// <summary>
		/// インスタンス
		/// </summary>
		private static App _instance;

		/// <summary>
		/// アプリケーションのインスタンス
		/// </summary>
		public static App Instance => _instance;

		/// <inheritdoc />
		/// <summary>
		/// コンストラクタ
		/// </summary>
		private App() => _instance = this;

		#endregion

		#region フィールド

		/// <summary>
		/// タスクトレイのアイコン
		/// </summary>
		private NotifyIconWrapper _notifyIcon;



		#endregion


		#region プロパティ
		

		#endregion


		/// <inheritdoc />
		/// <summary>
		/// スタートアップイベント
		/// </summary>
		/// <param name="e">イベントデータ</param>
		protected override void OnStartup(StartupEventArgs e) {
			base.OnStartup(e);
			this.MainWindow = new MainWindow();
			this.ShutdownMode = ShutdownMode.OnExplicitShutdown;
			this._notifyIcon = new NotifyIconWrapper();

		}

		/// <inheritdoc />
		/// <summary>
		/// 終了イベント
		/// </summary>
		/// <param name="e">イベントデータ</param>
		protected override void OnExit(ExitEventArgs e) {
			base.OnExit(e);
			this._notifyIcon.Dispose();
		}

		public class TestClass {

			public UserTokenKeyPair User1 { get; set; }

			public UserTokenKeyPair User2 { get; set; }

			public string A { get; set; }

			public UserTokenKeyPair User3 { get; set; }

		}
	}
}
