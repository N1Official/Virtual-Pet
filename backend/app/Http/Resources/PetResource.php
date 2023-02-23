<?php

namespace App\Http\Resources;

use Illuminate\Http\Resources\Json\JsonResource;

class Petresource extends JsonResource
{
    public $preserveKeys = true;
    /**
     * Transform the resource into an array.
     *
     * @param  \Illuminate\Http\Request  $request
     * @return array|\Illuminate\Contracts\Support\Arrayable|\JsonSerializable
     */
    public function toArray($request)
    {
        return [
            "id" => $this->id,
            "name" => $this->name,
            "type" => $this->type,
            "hunger" => $this->hunger,
            "thirst" => $this->thirst,
            "mood" => $this->mood,
            "speed" => $this->speed,
            "health" => $this->health,
            "skill" => $this->skill,
            "age" => $this->age,
            "age_group" => $this->age_group,
        ];
    }
}
