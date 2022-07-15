using System;

namespace Practica {
	public class CustomException {
		private string _nameEx;

		public CustomException() {
			_nameEx = "Fail!";
		}

		public void Fail() {
			throw new Exception(_nameEx);
		}
	}
}