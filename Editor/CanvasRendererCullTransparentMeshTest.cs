using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;

namespace Kogane.Internal
{
	internal sealed class CanvasRendererCullTransparentMeshTest
	{
		[Category( nameof( Kogane ) )]
		[Test]
		public void 透明な_UI_の_Cul_Transparent_Mesh_がオンになっているか()
		{
			bool IsValid( GameObject gameObject )
			{
				var graphic = gameObject.GetComponent<Graphic>();
				if ( graphic == null ) return true;
				var canvasRenderer = gameObject.GetComponent<CanvasRenderer>();
				if ( canvasRenderer == null ) return true;
				var mask = gameObject.GetComponent<Mask>();
				if ( mask != null ) return true;
				return 0 < graphic.color.a || canvasRenderer.cullTransparentMesh;
			}

			AllGameObjectTester.Test( IsValid );
		}
	}
}