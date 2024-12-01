#version 330 core

out vec4 color;

in vec2 texCoord;

uniform sampler2D ourTexture;
uniform vec4 orbitColor;
uniform bool useTexture;

void main()
{
//color = vec4(1.0f, 1.0f, 1.0f, 1.0f);
if (useTexture)
    {
        color = texture(ourTexture, texCoord);
    }
    else
    {
        color = orbitColor;
    }
}