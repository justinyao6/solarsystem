#version 330 core

out vec4 color;  // Final output color

uniform vec4 orbitColor;  // Uniform for dynamic color control

void main()
{
    color = orbitColor;  // Use the uniform color
}
