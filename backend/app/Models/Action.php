<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Action extends Model
{
    protected $fillable = [
        "action"
    ];

    use HasFactory;
    protected $table = 'actions';
    protected $primaryKey = 'id';
    public $timestamps = false;
}
