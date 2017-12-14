Shader "Character/CharacterShader"
{
	Properties
	{
		_MainTex ("Texture", 2D) = ""{}
	}
	SubShader
	{
		pass{
			SetTexture[_MainTex]
		}
		
	}
}
