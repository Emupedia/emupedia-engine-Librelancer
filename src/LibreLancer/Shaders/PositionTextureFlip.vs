﻿#version 140

in vec3 vertex_position;
in vec3 vertex_normal;
in vec2 vertex_texture1;

out vec2 out_texcoord;
out vec3 out_normal;
out vec3 world_position;
uniform mat4x4 World;
uniform mat4x4 ViewProjection;

void main()
{
	gl_Position = (ViewProjection * World) * vec4(vertex_position, 1.0);
	vec2 texcoord = vec2(vertex_texture1.x, vertex_texture1.y);
	world_position = (vec4(vertex_position,1) * World).xyz;
	out_normal = (vec4(vertex_normal,1) * World).xyz;
	out_texcoord = texcoord;
}
