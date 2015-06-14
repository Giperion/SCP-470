Shader "SCP470/SimpleBookShader" {
	Properties {
		_MainTex ("Base (RGB)", 2D) = "white" {}
		_textTexture ("Text on book", 2D) = "white" {}
		_modeSwitch ("Add or Multiplay", range (0, 1)) = 0
	}
	SubShader {
		Tags { "RenderType"="Opaque" }
		LOD 200
		
		CGPROGRAM
		#pragma surface surf Lambert

		sampler2D _MainTex;
		sampler2D _textTexture;
		fixed _modeSwitch;

		struct Input {
			float2 uv_MainTex;
		};

		void surf (Input IN, inout SurfaceOutput o) {
			half4 main = tex2D (_MainTex, IN.uv_MainTex);
			half4 text = tex2D (_textTexture, IN.uv_MainTex);
			if (_modeSwitch == 1){
			half4 finalColor_2 = main + text;
			o.Albedo = finalColor_2.rgb;
			}
			else
			{
			half4 finalColor_1 = main * text;
			o.Albedo = finalColor_1.rgb;
			}
		}
		ENDCG
	} 
	FallBack "Diffuse"
}
