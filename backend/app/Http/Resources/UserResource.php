<?php

namespace App\Http\Resources;

use Illuminate\Http\Resources\Json\JsonResource;

class Userresource extends JsonResource
{
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
                "username" => $this->username,
                "email" => $this->email,
                "password" => $this->password,
                "firstName" => $this->firstName,
                "lastName" => $this->lastName,
                "gender" => $this->gender,
                "birthday" => $this->birthday,
                "phone" => $this->phone,
                "address" => $this->address,
                "city" => $this->city,
                "state" => $this->state,
                "zipcode" => $this->zipcode,
                "country" => $this->country,
            ];
       
    }
}
