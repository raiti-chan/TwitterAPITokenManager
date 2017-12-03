using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using static System.String;

namespace TwitterAPITokenManager.Setting {

	/// <inheritdoc />
	/// <summary>
	/// ユーザーのキーとシークレットキーのペア要素
	/// </summary>
	public class UserTokenKeyPair : IXmlSerializable{

		/// <summary>
		/// ユーザートークン
		/// </summary>
		public string AccessToken { get; private set; }

		/// <summary>
		/// シークレットトークンキー
		/// </summary>
		public string AccessTokenSecret { get; private set; }

		/// <summary>
		/// ペア要素を生成します。
		/// </summary>
		/// <param name="token">トークン</param>
		/// <param name="secret">シークレット</param>
		public UserTokenKeyPair(string token, string secret) {
			this.AccessToken = token;
			this.AccessTokenSecret = secret;
		}

		/// <summary>
		/// デシリアライズ用
		/// </summary>
		public UserTokenKeyPair() {
			
		}


		public XmlSchema GetSchema() => null;

		public void ReadXml(XmlReader reader) {
			reader.Read();
			if (reader.IsEmptyElement) {
				return;
			}

			SerializeObject serializeObject = (SerializeObject) new XmlSerializer(typeof(SerializeObject)).Deserialize(reader);
			

			this.AccessToken = serializeObject.AccessToken;
			this.AccessTokenSecret = serializeObject.AccessTokenSecret;
			reader.Read();
		}

		public void WriteXml(XmlWriter writer) {
			SerializeObject serializeObject = new SerializeObject {
				AccessToken = this.AccessToken,
				AccessTokenSecret = this.AccessTokenSecret
			};
			new XmlSerializer(typeof(SerializeObject)).Serialize(writer, serializeObject);
		}

		/// <summary>
		/// シリアライズ用オブジェクト
		/// </summary>
		[XmlRoot("UserTokenKeyPair")]
		public class SerializeObject {


			public string AccessToken = Empty;

			public string AccessTokenSecret = Empty;

		}

	}
}
